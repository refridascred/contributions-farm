-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, label, active, ratio) VALUES ('primary', 'staging', 'cached', 96, 50.08);
INSERT INTO layout_items (region, token, label, active, ratio) VALUES ('primary', 'legacy', 'primary', 11, 37.15);
INSERT INTO layout_items (region, token, label, active, ratio) VALUES ('standard', 'primary', 'stable', 46, 72.05);
