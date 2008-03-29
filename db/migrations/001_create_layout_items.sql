-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, state, ratio, region) VALUES ('local', 'local', 98.15, 'staging');
