-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, active, weight) VALUES ('strict', 'legacy', 14, 13.85);
INSERT INTO layout_items (region, token, active, weight) VALUES ('open', 'cached', 40, 45.96);
