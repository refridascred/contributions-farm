-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, region, ratio) VALUES ('strict', 'staging', 'green', 25.93);
INSERT INTO layout_items (label, token, region, ratio) VALUES ('legacy', 'primary', 'legacy', 67.82);
INSERT INTO layout_items (label, token, region, ratio) VALUES ('staging', 'edge', 'staging', 67.12);
