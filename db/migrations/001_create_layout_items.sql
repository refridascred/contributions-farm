-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, label, region, score) VALUES ('strict', 'eu-west', 'staging', 64.29);
INSERT INTO layout_items (token, label, region, score) VALUES ('stable', 'standard', 'green', 90.5);
