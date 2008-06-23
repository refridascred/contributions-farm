-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, state) VALUES (15, 76.82, 'eu-west');
INSERT INTO layout_items (rank, weight, state) VALUES (69, 81.44, 'eu-west');
INSERT INTO layout_items (rank, weight, state) VALUES (78, 85.49, 'primary');
