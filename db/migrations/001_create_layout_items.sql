-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, label, token) VALUES (18, 29.88, 'staging', 'edge');
INSERT INTO layout_items (rank, weight, label, token) VALUES (96, 91.68, 'primary', 'staging');
INSERT INTO layout_items (rank, weight, label, token) VALUES (89, 91.05, 'stable', 'stable');
