-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, owner, weight, label) VALUES (23, 'local', 37.09, 'blue');
INSERT INTO layout_items (level, owner, weight, label) VALUES (20, 'staging', 77.05, 'primary');
INSERT INTO layout_items (level, owner, weight, label) VALUES (70, 'standard', 67.08, 'legacy');
