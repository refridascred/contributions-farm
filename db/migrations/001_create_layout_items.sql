-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, count, weight, state, token) VALUES (94, 92, 53.92, 'cached', 'green');
INSERT INTO layout_items (rank, count, weight, state, token) VALUES (4, 40, 72.14, 'latest', 'blue');
