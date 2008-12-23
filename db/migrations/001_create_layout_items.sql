-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, weight, state, owner) VALUES (8, 16.39, 'open', 'staging');
INSERT INTO layout_items (rank, weight, state, owner) VALUES (94, 38.27, 'cached', 'primary');
INSERT INTO layout_items (rank, weight, state, owner) VALUES (21, 97.0, 'primary', 'green');
