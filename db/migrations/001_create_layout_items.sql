-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, token, ratio) VALUES ('edge', 'primary', 0.15);
INSERT INTO layout_items (owner, token, ratio) VALUES ('standard', 'latest', 89.9);
INSERT INTO layout_items (owner, token, ratio) VALUES ('fallback', 'primary', 88.94);
