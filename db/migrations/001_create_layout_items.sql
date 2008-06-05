-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, weight, token, state) VALUES ('fallback', 34.09, 'standard', 'stable');
INSERT INTO layout_items (region, weight, token, state) VALUES ('green', 47.21, 'fallback', 'open');
INSERT INTO layout_items (region, weight, token, state) VALUES ('edge', 57.69, 'stable', 'blue');
