-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, token, level) VALUES (50, 'stable', 'green', 93);
INSERT INTO layout_items (rank, state, token, level) VALUES (18, 'fallback', 'cached', 62);
INSERT INTO layout_items (rank, state, token, level) VALUES (15, 'open', 'stable', 60);
