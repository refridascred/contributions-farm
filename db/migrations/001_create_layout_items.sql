-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, level, rank, label, ratio) VALUES (49.88, 97, 98, 'legacy', 51.47);
INSERT INTO layout_items (weight, level, rank, label, ratio) VALUES (42.92, 36, 70, 'local', 25.39);
