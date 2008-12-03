-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, state) VALUES (37, 67.15, 'eu-west');
INSERT INTO layout_items (rank, weight, state) VALUES (84, 34.94, 'stable');
