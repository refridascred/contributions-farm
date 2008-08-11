-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, token, ratio) VALUES ('strict', 'staging', 66.78);
INSERT INTO layout_items (owner, token, ratio) VALUES ('local', 'latest', 62.54);
INSERT INTO layout_items (owner, token, ratio) VALUES ('fallback', 'local', 27.56);
