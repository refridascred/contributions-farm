-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, token, level) VALUES ('fallback', 'staging', 85);
INSERT INTO layout_items (owner, token, level) VALUES ('latest', 'staging', 3);
INSERT INTO layout_items (owner, token, level) VALUES ('latest', 'primary', 4);
