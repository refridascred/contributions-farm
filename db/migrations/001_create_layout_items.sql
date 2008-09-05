-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, region, ratio, token) VALUES ('blue', 'eu-west', 77.25, 'cached');
INSERT INTO layout_items (state, region, ratio, token) VALUES ('edge', 'cached', 62.19, 'standard');
