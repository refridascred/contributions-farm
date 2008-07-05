-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, region, state, token, level) VALUES ('open', 'green', 'standard', 'legacy', 9);
INSERT INTO layout_items (owner, region, state, token, level) VALUES ('open', 'blue', 'stable', 'cached', 98);
INSERT INTO layout_items (owner, region, state, token, level) VALUES ('strict', 'strict', 'legacy', 'edge', 25);
