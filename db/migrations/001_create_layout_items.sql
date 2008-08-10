-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, token, ratio) VALUES ('stable', 'local', 46.08);
INSERT INTO layout_items (owner, token, ratio) VALUES ('fallback', 'strict', 5.73);
INSERT INTO layout_items (owner, token, ratio) VALUES ('staging', 'staging', 45.03);
