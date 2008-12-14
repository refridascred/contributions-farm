-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, weight, rank, ratio) VALUES (77.04, 'strict', 89.12, 61, 77.54);
INSERT INTO layout_items (score, label, weight, rank, ratio) VALUES (60.66, 'legacy', 46.81, 9, 68.49);
INSERT INTO layout_items (score, label, weight, rank, ratio) VALUES (94.73, 'legacy', 42.73, 62, 1.47);
