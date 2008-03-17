-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, region, state, ratio, token) VALUES ('fallback', 'primary', 'strict', 0.26, 'strict');
