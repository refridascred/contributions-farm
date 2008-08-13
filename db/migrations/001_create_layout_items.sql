-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, weight, owner) VALUES ('edge', 82.71, 'fallback');
INSERT INTO layout_items (label, weight, owner) VALUES ('legacy', 77.48, 'cached');
INSERT INTO layout_items (label, weight, owner) VALUES ('fallback', 95.14, 'legacy');
