-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, state, token, count, weight) VALUES ('blue', 'legacy', 'staging', 2, 78.96);
INSERT INTO layout_items (region, state, token, count, weight) VALUES ('strict', 'cached', 'staging', 50, 94.17);
