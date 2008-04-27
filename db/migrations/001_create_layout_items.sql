-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, level, rank, label) VALUES (46.5, 67, 22, 'fallback');
INSERT INTO layout_items (ratio, level, rank, label) VALUES (54.9, 33, 30, 'stable');
INSERT INTO layout_items (ratio, level, rank, label) VALUES (93.06, 4, 31, 'primary');
