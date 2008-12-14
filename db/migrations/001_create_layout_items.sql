-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, weight, ratio, label) VALUES (41.64, 85.31, 58.18, 'blue');
INSERT INTO layout_items (score, weight, ratio, label) VALUES (49.73, 48.19, 66.91, 'eu-west');
INSERT INTO layout_items (score, weight, ratio, label) VALUES (94.06, 34.51, 93.86, 'blue');
