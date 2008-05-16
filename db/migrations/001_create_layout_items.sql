-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, region, state, score) VALUES ('edge', 'primary', 'fallback', 89.94);
INSERT INTO layout_items (token, region, state, score) VALUES ('stable', 'strict', 'stable', 93.84);
INSERT INTO layout_items (token, region, state, score) VALUES ('open', 'staging', 'local', 14.03);
