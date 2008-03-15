-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, region, state, token) VALUES (91, 'legacy', 'cached', 'latest');
INSERT INTO layout_items (active, region, state, token) VALUES (77, 'blue', 'cached', 'fallback');
INSERT INTO layout_items (active, region, state, token) VALUES (72, 'standard', 'cached', 'legacy');
