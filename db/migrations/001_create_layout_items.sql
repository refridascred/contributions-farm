-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, region, level, token) VALUES ('strict', 'green', 81, 'standard');
INSERT INTO layout_items (label, region, level, token) VALUES ('primary', 'open', 37, 'latest');
INSERT INTO layout_items (label, region, level, token) VALUES ('standard', 'standard', 80, 'stable');
