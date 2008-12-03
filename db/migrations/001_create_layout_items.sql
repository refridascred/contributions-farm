-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, ratio, score) VALUES ('edge', 80.69, 85.19);
INSERT INTO layout_items (label, ratio, score) VALUES ('latest', 25.23, 30.23);
INSERT INTO layout_items (label, ratio, score) VALUES ('strict', 40.32, 47.07);
