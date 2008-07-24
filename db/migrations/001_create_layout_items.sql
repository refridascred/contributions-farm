-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, active) VALUES ('strict', 66.73, 33);
INSERT INTO layout_items (token, ratio, active) VALUES ('open', 78.27, 94);
INSERT INTO layout_items (token, ratio, active) VALUES ('fallback', 45.15, 7);
