-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, level, score, count) VALUES ('standard', 69, 24.09, 49);
INSERT INTO layout_items (label, level, score, count) VALUES ('latest', 22, 15.62, 23);
INSERT INTO layout_items (label, level, score, count) VALUES ('eu-west', 46, 83.24, 84);
