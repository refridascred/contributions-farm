-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, active, region, label) VALUES (11.67, 51, 'staging', 'legacy');
INSERT INTO layout_items (weight, active, region, label) VALUES (76.82, 54, 'eu-west', 'strict');
INSERT INTO layout_items (weight, active, region, label) VALUES (83.08, 95, 'legacy', 'stable');
