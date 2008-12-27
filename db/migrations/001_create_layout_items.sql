-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, state, token) VALUES (63, 71.12, 'legacy', 'fallback');
INSERT INTO layout_items (rank, weight, state, token) VALUES (94, 14.39, 'staging', 'legacy');
