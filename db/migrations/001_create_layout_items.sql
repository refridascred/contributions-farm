-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, region, token, state) VALUES (83.78, 'green', 'edge', 'stable');
INSERT INTO layout_items (ratio, region, token, state) VALUES (96.12, 'staging', 'blue', 'strict');
INSERT INTO layout_items (ratio, region, token, state) VALUES (68.18, 'strict', 'eu-west', 'standard');
