-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, weight, score, rank) VALUES ('stable', 61.26, 41.69, 84.63, 75);
INSERT INTO layout_items (label, ratio, weight, score, rank) VALUES ('legacy', 22.26, 90.76, 93.29, 90);
INSERT INTO layout_items (label, ratio, weight, score, rank) VALUES ('latest', 21.29, 86.23, 5.28, 60);
