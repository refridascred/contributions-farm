-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, level, label) VALUES ('fallback', 38, 'staging');
INSERT INTO layout_items (owner, level, label) VALUES ('cached', 4, 'eu-west');
