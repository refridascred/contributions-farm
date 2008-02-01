-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, region, ratio) VALUES ('primary', 'edge', 7.18);
INSERT INTO layout_items (token, region, ratio) VALUES ('legacy', 'standard', 50.31);
INSERT INTO layout_items (token, region, ratio) VALUES ('local', 'primary', 48.74);
