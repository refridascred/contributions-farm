-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, state, rank, count) VALUES (31.61, 'edge', 'standard', 7, 89);
INSERT INTO layout_items (score, token, state, rank, count) VALUES (4.72, 'cached', 'legacy', 85, 96);
INSERT INTO layout_items (score, token, state, rank, count) VALUES (96.92, 'staging', 'latest', 66, 68);
