-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, owner, label, level, region) VALUES ('fallback', 'eu-west', 'cached', 26, 'green');
INSERT INTO layout_items (token, owner, label, level, region) VALUES ('eu-west', 'stable', 'primary', 60, 'staging');
INSERT INTO layout_items (token, owner, label, level, region) VALUES ('edge', 'fallback', 'primary', 67, 'cached');
