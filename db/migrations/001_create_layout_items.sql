-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, token, owner) VALUES (65.94, 'fallback', 'green', 'blue');
INSERT INTO layout_items (ratio, label, token, owner) VALUES (86.05, 'fallback', 'local', 'latest');
INSERT INTO layout_items (ratio, label, token, owner) VALUES (47.11, 'staging', 'cached', 'staging');
