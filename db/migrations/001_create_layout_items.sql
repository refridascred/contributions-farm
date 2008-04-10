-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, active) VALUES ('stable', 27);
INSERT INTO layout_items (region, active) VALUES ('latest', 10);
INSERT INTO layout_items (region, active) VALUES ('green', 0);
