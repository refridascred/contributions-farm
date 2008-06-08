-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, token, level, region, ratio) VALUES ('legacy', 'fallback', 2, 'staging', 57.93);
INSERT INTO layout_items (label, token, level, region, ratio) VALUES ('standard', 'fallback', 72, 'legacy', 44.79);
INSERT INTO layout_items (label, token, level, region, ratio) VALUES ('primary', 'local', 39, 'eu-west', 48.16);
