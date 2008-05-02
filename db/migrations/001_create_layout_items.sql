-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, active) VALUES ('primary', 'standard', 5);
INSERT INTO layout_items (label, region, active) VALUES ('eu-west', 'primary', 12);
INSERT INTO layout_items (label, region, active) VALUES ('staging', 'latest', 86);
