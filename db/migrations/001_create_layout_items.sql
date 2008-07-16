-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, active, score, weight) VALUES ('latest', 70, 37.06, 89.38);
INSERT INTO layout_items (region, active, score, weight) VALUES ('standard', 94, 78.86, 73.31);
INSERT INTO layout_items (region, active, score, weight) VALUES ('eu-west', 28, 96.16, 91.1);
