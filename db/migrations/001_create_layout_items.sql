-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, state, token, weight, owner) VALUES ('cached', 'fallback', 'primary', 14.65, 'cached');
INSERT INTO layout_items (region, state, token, weight, owner) VALUES ('primary', 'standard', 'edge', 54.48, 'cached');
INSERT INTO layout_items (region, state, token, weight, owner) VALUES ('strict', 'strict', 'staging', 69.67, 'stable');
