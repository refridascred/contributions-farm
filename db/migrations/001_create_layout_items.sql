-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, level, region) VALUES ('strict', 'cached', 12, 'cached');
INSERT INTO layout_items (label, token, level, region) VALUES ('stable', 'green', 80, 'latest');
INSERT INTO layout_items (label, token, level, region) VALUES ('open', 'stable', 92, 'primary');
