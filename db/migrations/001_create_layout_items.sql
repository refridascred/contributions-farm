-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, token, ratio) VALUES ('primary', 'cached', 65.96);
INSERT INTO layout_items (region, token, ratio) VALUES ('strict', 'fallback', 49.4);
