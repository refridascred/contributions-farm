-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, rank, count, ratio) VALUES ('fallback', 58, 30, 95.44);
INSERT INTO layout_items (label, rank, count, ratio) VALUES ('standard', 41, 90, 65.62);
INSERT INTO layout_items (label, rank, count, ratio) VALUES ('blue', 95, 18, 72.83);
