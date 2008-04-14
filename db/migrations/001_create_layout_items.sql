-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, ratio, rank, label, active) VALUES (90.33, 42.12, 31, 'open', 32);
INSERT INTO layout_items (weight, ratio, rank, label, active) VALUES (72.56, 18.74, 35, 'legacy', 95);
INSERT INTO layout_items (weight, ratio, rank, label, active) VALUES (96.85, 49.57, 13, 'strict', 79);
