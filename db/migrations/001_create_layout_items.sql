-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, active, score) VALUES ('stable', 'legacy', 15, 36.08);
INSERT INTO layout_items (label, region, active, score) VALUES ('local', 'primary', 90, 78.68);
INSERT INTO layout_items (label, region, active, score) VALUES ('primary', 'primary', 36, 12.2);
