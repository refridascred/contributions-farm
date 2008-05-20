-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, state, ratio, token) VALUES (52, 'blue', 56.82, 'stable');
INSERT INTO layout_items (rank, state, ratio, token) VALUES (17, 'strict', 3.87, 'latest');
INSERT INTO layout_items (rank, state, ratio, token) VALUES (2, 'cached', 37.66, 'local');
