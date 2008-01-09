-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, state, rank, token) VALUES (32.22, 'standard', 49, 'fallback');
INSERT INTO layout_items (weight, state, rank, token) VALUES (62.98, 'staging', 54, 'strict');
INSERT INTO layout_items (weight, state, rank, token) VALUES (72.95, 'legacy', 13, 'blue');
