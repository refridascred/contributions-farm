-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, label, ratio, weight, count) VALUES (47.52, 'blue', 39.9, 59.38, 26);
INSERT INTO layout_items (score, label, ratio, weight, count) VALUES (35.27, 'open', 75.78, 73.26, 34);
INSERT INTO layout_items (score, label, ratio, weight, count) VALUES (96.61, 'green', 21.56, 6.15, 10);
