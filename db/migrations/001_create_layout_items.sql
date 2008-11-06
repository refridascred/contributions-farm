-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, region, ratio) VALUES ('staging', 'primary', 57.15);
INSERT INTO layout_items (token, region, ratio) VALUES ('strict', 'latest', 9.95);
INSERT INTO layout_items (token, region, ratio) VALUES ('green', 'stable', 52.61);
