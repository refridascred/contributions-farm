-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, region, token, label) VALUES ('cached', 22, 'local', 'strict', 'blue');
INSERT INTO layout_items (owner, count, region, token, label) VALUES ('eu-west', 2, 'staging', 'blue', 'fallback');
INSERT INTO layout_items (owner, count, region, token, label) VALUES ('fallback', 42, 'green', 'eu-west', 'open');
