-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, token, state, label) VALUES (13.69, 4, 'primary', 'eu-west', 'eu-west');
INSERT INTO layout_items (weight, rank, token, state, label) VALUES (74.98, 15, 'edge', 'green', 'stable');
