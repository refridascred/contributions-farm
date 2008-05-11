-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, ratio, score) VALUES ('local', 'fallback', 24.8, 36.05);
INSERT INTO layout_items (label, region, ratio, score) VALUES ('eu-west', 'latest', 69.02, 98.73);
INSERT INTO layout_items (label, region, ratio, score) VALUES ('eu-west', 'green', 6.4, 61.09);
