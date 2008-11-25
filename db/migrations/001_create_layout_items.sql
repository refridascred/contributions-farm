-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, rank, weight, label, region) VALUES (83, 71, 63.74, 'strict', 'local');
INSERT INTO layout_items (level, rank, weight, label, region) VALUES (43, 16, 87.37, 'open', 'primary');
