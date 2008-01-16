-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, weight, score, active) VALUES ('primary', 10.32, 63.89, 47);
INSERT INTO layout_items (token, weight, score, active) VALUES ('local', 27.09, 67.37, 98);
INSERT INTO layout_items (token, weight, score, active) VALUES ('eu-west', 48.4, 34.91, 94);
