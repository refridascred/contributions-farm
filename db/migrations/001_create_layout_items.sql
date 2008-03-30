-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, region, score) VALUES ('standard', 'strict', 'legacy', 96.98);
INSERT INTO layout_items (state, owner, region, score) VALUES ('green', 'green', 'fallback', 33.37);
