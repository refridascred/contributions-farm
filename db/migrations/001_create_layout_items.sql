-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, ratio, owner) VALUES (6, 4.07, 'stable');
INSERT INTO layout_items (rank, ratio, owner) VALUES (25, 71.47, 'cached');
INSERT INTO layout_items (rank, ratio, owner) VALUES (6, 74.5, 'green');
