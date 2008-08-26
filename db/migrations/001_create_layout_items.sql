-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, label, ratio) VALUES ('latest', 'primary', 78.29);
INSERT INTO layout_items (region, label, ratio) VALUES ('open', 'fallback', 38.11);
INSERT INTO layout_items (region, label, ratio) VALUES ('open', 'staging', 96.88);
