-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, score, state, token, region) VALUES ('local', 52.66, 'cached', 'open', 'fallback');
INSERT INTO layout_items (owner, score, state, token, region) VALUES ('green', 43.75, 'edge', 'standard', 'green');
INSERT INTO layout_items (owner, score, state, token, region) VALUES ('legacy', 50.8, 'strict', 'legacy', 'open');
